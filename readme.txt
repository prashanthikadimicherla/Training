Back End:

The back end has 3 projects

1. Training - This is the web api project.
2. Training.DataAccess - This has the entity framework with code first approach.
3.Training.Test - This has the unit test cases with Moq and NUnit framework.

In order to run the project:

1. Go to the Training project, web.config file. This has the connection string "TrainingContext.". It is currently pointing to my localhost.
2. In order to create a database at your end, please feel free to change the connection string as required. The Add-Migrations are enabled for it.
3. To create a database, first enter "Add-Migrations" command and then give it a name. Then enter "update-database" command which would create database and table.
4. Then run the training project and enter the URL in Postman "http://localhost:57857/api/training/add". This is a HttpPost.
5. The example for a json request body is :

{
	"TrainingName": ".net basics",
	"TrainingStartDate":"07-09-2019",
	"TrainingEndDate": "07-11-2019"
}


6. By running this it will create a row in the "Training" database, "TrainingDetails" table.


Features used:

1. It has Automapper for mapping of models.
2. It has IOC container, Autofac for dependency injection.
3. It has model validations in the Model -> TrainingModel.cs file.
4. The validation for "End date should be greater than start date" has been implemented in both Front End and Back end. 
The reason its done in back end is , if we just access the backend it should still throw error in case the request is wrong.


Front End:

The front end is implemented in Angular 8 and Bootstrap 4.
The project is been created with Angular CLI

In order to run the project:

1. Install node.js. I have used "10.16.2" version.
2. npm install. This would install all the packages in the package.json file.
3. The front end calls the back end API. The back end URL is configured in  "Environment.ts" file. 
4. Ensure that the backend API is running.
5. Run the command "ng-serve".
6. The run "http://localhost:4200" , which would run the front end project.

Features used:

1. The datetime picker is used from "ngx-datetime-picker" module.
2. SCSS "training.componenet.scss" has been used for style sheets.
3. The global CSS like bootstrap and ngx-datetime-picker is present in the Styles.scss.
4. The validations is present in the validate method in the training.componenet.ts file.
 

 

