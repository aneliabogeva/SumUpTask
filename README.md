# Automations tests for point 1

#Dependencies
- in order to run the automation tests suite:
	- clone repository "SumUpTask" from this location https://github.com/aneliabogeva/SumUpTask	

#Running Tests 
The following steps should get you set up for running automation tests locally on your machine:

1. Open "TransactionTest" class from Solution explorer
2. Rebuild the solution and restore packages if needed
3. Verify that you are able to see Test Explorer
4. Find the correct branch - in this particular case branch is only one
5. If you want to run the whole siute - just click the button "Run All" from the left part of the panel 
6. If you want to run only one particular test - find the name of the test you are interesting in, right click and from the menu - Run selected test

Note: If you are interesting in the way how the project is build here are some main topics:
1. From Solution Explorer navigate to the Page folder and open it
2. In the pages there is Basic page where driver is initalized and wait is declare
3. The other two pages TrPage and TrPageMap are the pages linked to finding elements and reuse methods
4. Tests are located in class named: TransactionTest

#Point 2
1. API call to LogIn screen - POST request with end point: https://me.sumup.com/api/session-info - provide to the user Loginscreen and the respons take all needed information in the body. Status code is 200 which means that is OK and the user can go further. There is no errors and delays, response time is ok. 
2. After fulfill the needed information ot the loginscreen, the next call is POST request with all the information for username, password and authorization token to the endpoint for login: https://me.sumup.com/api/oauth. Status Code: 200 OK means that request was succesfully executed without errors
3. Get method retrive the main information after login - Status Code is 200 OK, information retrived successfully from the endpoint: https://me.sumup.com/api/v0.1/me/app-settings
4. Information regarding activation code of the account is send with POST request to the endpoint: https://me.sumup.com/api/v0.1/me/device-activation-code, Status Code: 404 Not Found - means that information for the activation code is not located and not found. 

#Point 3
- All customers from United States:
	  select * from customers where Country like "United States"
- All customers whose details were not updated from their creation on:
	  select * from customer_details where Created_at = Updated_at
- The average customer age per country
	  select AVG(Age) from customer_details cd
	  join customer c on cd.Cudtomer_id = c.id
	  group by Period
