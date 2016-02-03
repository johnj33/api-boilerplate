Feature: ValidateCar
	As a story description 
	When i am  writen
	I would like to contain some information

Scenario: Given a car endpoint When that endpoint is called a list of cars is returned
	Given the following car data 
	| car Type | registration | year Bought |
	| ford     | jd23riri     | 2015        |
	| porche   | ej29ksks     | 2014        |
	When the endpoint is called 
	Then the following data should be returned
	And the api will return a response of OK 
