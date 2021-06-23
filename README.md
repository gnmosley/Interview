# Interview
Interview for Dayton Freight

Done so far

Fixes:
1. Fixed the issue printing professor name
	Added an Include onto the return statement in the EnrollmentProvider class
2. 
	-Added endpoint that allows a student to enroll in a maximum of 2 courses
		Created a query to obtain the number of enrollments from the student Id using _context
		if the number of results from the query > 2 throw exception
		Created in the EnrollmentCountRule class
	-Unable to add endpoint that restrict enrollment if the professor given does not teach the course given
		Current issue: When querying the coureProfessor information, only the first Course added is obtained
			ex1: Dr. James -- Course 1, 2, and 3 are added to the CourseProfessors, however when queried only course id 1
			will be the result of the query.
			ex2: Dr. James -- Course 3, 2, and 1 are added to the CourseProfessors, however when queried only course id 3
			will be the result of the query.
		I'm not exactly sure how attachments works, but when traversing the CourseProfessors, all courses are there however 		after the adding the Professor to the db, only 1 is displaying.
		Progress made is in EnrollmentCountRule class
3. 
	- To do: 
		After Enrollment is created, add the enrollment to the Student object.
		Attach enrollment to context
		Student: Enrollments has a getter to retrieve all the enrollments.
