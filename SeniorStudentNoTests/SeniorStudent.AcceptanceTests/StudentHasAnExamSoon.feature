Feature: Student Has an Exam Soon
	In order to get through college
	As a student
	I must study and pass exams

Scenario: Student Has Exam Soon Without Studying
	Given I am a student
	And I have a textbook
	And I have not read the textbook
	When I study for the exam that is in five minutes
	Then I will die

Scenario: Student Takes Exam With Studying
	Given I am a student
	And I have a textbook
	And I have read the textbook
	When I study for the exam that is in five minutes
	Then I will be okay :)