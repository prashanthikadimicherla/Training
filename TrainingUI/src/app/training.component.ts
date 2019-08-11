import { Component, OnInit } from '@angular/core';
import { TrainingDetails } from './trainingdetails';
import { TrainingService } from './training.service';

@Component({
  selector: 'training-root',
  templateUrl: './training.component.html',
  styleUrls: ['./training.component.scss'],
  providers: [TrainingService]
})
export class TrainingComponent  {
  success: string;
  training = new TrainingDetails();
  errorMessage: String;
  constructor(private trainingService: TrainingService) { }
  addBook(): void {
    this.success = '';
    this.errorMessage = '';
    //Validatuion
    if(this.validate()){
     
    this.trainingService.addTrainingWithObservable(this.training)
      .subscribe( training => {
        let diffInMs: number = Date.parse(this.training.endDate.toDateString()) - Date.parse(this.training.startDate.toDateString());
        let diffInDays: number = diffInMs / 1000 / 60 / 60 /24;

        this.success = 'The training details are successfully created and the number of days between start and end date is '+ diffInDays; 						   
      },
                        error => this.errorMessage = <any>error);
    }
  }

  validate(){
    if(this.training.trainingName === '' || this.training.trainingName === undefined){
      this.errorMessage = "Training name is required";
      return false;
    }
    if( this.training.startDate === undefined){
      this.errorMessage = "Start date is required";
      return false;
    }
    if( this.training.endDate === undefined){
      this.errorMessage = "End date is required";
      return false;
    }
   
    if( this.training.endDate < this.training.startDate){
      this.errorMessage = "End date should be after start date";
      return false;
    }
    return true;
  }
}
