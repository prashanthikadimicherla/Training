import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { catchError, map } from 'rxjs/operators';
import { TrainingDetails } from './TrainingDetails';
import { environment } from '../environments/environment';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class TrainingService {
    url = environment.apiBaseUrl + "api/training/add";
    constructor(private http:Http) { }
    
    addTrainingWithObservable(trainingDetails:TrainingDetails): Observable<TrainingDetails> {
        trainingDetails.trainingStartDate = trainingDetails.startDate.getFullYear() + '-'+ (trainingDetails.startDate.getMonth()+1) + '-'+trainingDetails.startDate.getDate() ;
        trainingDetails.trainingEndDate =  trainingDetails.endDate.getFullYear() + '-'+ (trainingDetails.endDate.getMonth() + 1 ) +'-'+ trainingDetails.endDate.getDate() ;
	    let headers = new Headers({ 'Content-Type': 'application/json' });
        //Call to http://localhost:57857/api/training/add to add training
        return this.http.post(this.url, trainingDetails)
                   .map(this.extractData)
                   .catch(this.handleErrorObservable);
    }

    private extractData(res: Response) {
        let body = res.json();
            return body || {};
        }
        private handleErrorObservable (error: Response | any) {
        console.error(error._body || error);
        return Observable.throw(error._body || error);
        }

    }