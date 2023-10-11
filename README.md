// Megha Panchani
//Student Id: W0836064
//Date : 9/10/2023
//Assignment 1

Date: 9/10/2023 
Time: 10:08AM
In the process of setting up my ASP.NET Core MVC project."I'm currently in the early stages of my ASP.NET web application project, naming it 'Megha_Stick' with 'Stick' as the central theme. After completing the initial step, I add a file to the 'Controller' folder, naming it 'HelloWorldController.cs.' I run this file and follow the steps provided in the PDF."

"For the next step, I add a view. I continue by modifying the 'HelloWorld' index using the code given in the PDF. I create a new folder, 'HelloWorld,' in the 'Views' directory and add a new item, 'Index.cshtml' file, replacing its code with the provided content. Then, I run the code in the browser, using the URL mentioned in the PDF."

"In the 'Views' folder, I make some adjustments to the 'Shared/_Layout.cshtml' file. I change the title, footer, and menu links to be in line with 'Product Stick,' as instructed in the PDF. I verify the code using the provided URL and confirm that everything is working as expected."

"While examining the files, I go to 'Views/HelloWorld/Index.cshtml,' where I replace the code with the instructions provided, making sure to change the title to 'Stick List' and the header to 'My Stick List,' in accordance with the PDF guidelines."

"Moving on to the next step, I create 'Welcome.cshtml' in 'Views/HelloWorld.' I copy the code from the file as outlined in the PDF. I also add the code to the 'HelloWorldController' to display the name a specific number of times and verify that everything is working properly up to this point."
In the next step, I add the model for the project. This involves creating a class named Stick.cs within the model. After that, I follow the instructions to open the Package Manager Console (PMC) from the Tools menu. In PMC, I successfully run the provided command. Additionally, I create a new main folder, 'Megha_Stick,' and within it, I establish the 'Data' folder. Inside 'Data,' I create 'StickContext.cs' and replace the term 'movie' with 'Stick' to align with the model I've created. I also update the 'Startup' file with the necessary using statements and configuration changes for SQL Server, ensuring all components are in harmony. After taking a 30-minute break, I proceed to create a scaffolded page for the 'Stick' in the 'Controller' folder, which automates the generation of the 'SticksController.' I continue by opening PMC and executing the 'Add-Migration InitialCreate' command, followed by 'Update-Database.' I also thoroughly test the application.

Subsequently, I delve into 'SticksController.cs,' comprehensively covering the various sections. Upon inspection, I notice that in the 'Views' folder, five files are automatically generated. Specifically, in 'Views/Sticks/Details.cshtml,' I examine the content and structure, ensuring it aligns with my expectations. Similarly, I analyze the contents of 'Views/Sticks/Index.cshtml.' With all these steps successfully completed, I can confidently state that I have progressed to the final step of the project.

In the next phase, I navigate to the View menu and open SQL Server Object Explorer to view the data in the 'dbo.Stick' table. After this, I proceed to create the 'SeedData' class in the 'Model' folder. I establish the database and insert ten stick entries into it. Additionally, I replace the content of 'program.cs' with the provided code and execute the application. As a result, the 'Sticks' table is populated with ten entries.

Moving forward, I delve into the task of adding controller methods and views. In the 'Models/Stick.cs' file, I include the necessary elements and perform thorough testing. While inspecting all the edits made, I ensure that everything aligns with the desired functionality. Upon running the application and testing the edit functionality, I encounter an issue related to the index. To address this, I modify the code and conduct another round of testing, ultimately confirming that the application is now functioning as intended.

Time: 12:17PM
Part 7 ,n the subsequent step, I focus on updating the 'Index' of 'Controllers/SticksController.cs'. After implementing the changes, I test the code using the provided URL. I thoroughly examine the previous code to ensure consistency. I then proceed to the 'Views/Sticks/Index.cshtml,' where I add form code utilizing the 'Sticks' data and verify that the product title bar displays as expected. The application runs smoothly, aligning precisely with the intended functionality.

Following this, I introduce another class, 'StickGripViewModel,' into the 'Models' folder. I update the code to include 'Sticks' in a list, 'GripType' as a 'SelectList,' and 'SelectedGripType' as a public string. In the 'SticksController.cs,' I replace the 'Index' method with the provided code, incorporating 'GripType.' I also update the 'Index.cshtml' in 'Views/Movies,' resulting in the addition of another bar. I ensure that the edit, create, new details, and all other functionalities continue to operate as intended.

At this stage, I extend the 'Models/Stick.cs' by adding the 'Rating' property. In 'SticksController.cs,' I integrate 'Rating,' and I make corresponding updates in 'Views/Movies/Index.cshtml,' 'Views/Sticks/Create.cshtml,' 'SeedData,' and perform the standard migration and code update process. I enhance the 'Stick' with the necessary attributes like 'Required,' 'StringLength,' 'RegularExpression,' and 'Range.' A thorough test confirms that the application now prompts users to provide comprehensive information when creating a new entry.

After meticulously examining all files and folders and retesting the product, I proceed to the final part of the PDF. In this phase, I scrutinize all the details and deletion functionality. Additionally, I add an 'About Us' folder in 'View/Home/' and draft content about the Stick, including details about different types of sticks, teams, and more. I incorporate the 'About Us' section into the '_Layout.cshtml' for a comprehensive and informative user experience.

Date: 10-10-2023
Time:2:11PM

In the subsequent step, I focus on updating the 'Index' of 'Controllers/SticksController.cs'. After implementing the changes, I test the code using the provided URL. I thoroughly examine the previous code to ensure consistency. I then proceed to the 'Views/Sticks/Index.cshtml,' where I add form code utilizing the 'Sticks' data and verify that the product title bar displays as expected. The application runs smoothly, aligning precisely with the intended functionality.

Following this, I introduce another class, 'StickGripViewModel,' into the 'Models' folder. I update the code to include 'Sticks' in a list, 'GripType' as a 'SelectList,' and 'SelectedGripType' as a public string. In the 'SticksController.cs,' I replace the 'Index' method with the provided code, incorporating 'GripType.' I also update the 'Index.cshtml' in 'Views/Movies,' resulting in the addition of another bar. I ensure that the edit, create, new details, and all other functionalities continue to operate as intended.

At this stage, I extend the 'Models/Stick.cs' by adding the 'Rating' property. In 'SticksController.cs,' I integrate 'Rating,' and I make corresponding updates in 'Views/Movies/Index.cshtml,' 'Views/Sticks/Create.cshtml,' 'SeedData,' and perform the standard migration and code update process. I enhance the 'Stick' with the necessary attributes like 'Required,' 'StringLength,' 'RegularExpression,' and 'Range.' A thorough test confirms that the application now prompts users to provide comprehensive information when creating a new entry.

After meticulously examining all files and folders and retesting the product, I proceed to the final part of the PDF. In this phase, I scrutinize all the details and deletion functionality. Additionally, I add an 'About Us' folder in 'View/Home/' and draft content about the Stick, including details about different types of sticks, teams, and more. I incorporate the 'About Us' section into the '_Layout.cshtml' for a comprehensive and informative user experience.
On the following day, I shift my focus to the CSS aspect of the project. I start by creating a CSS file in 'View/Stick' and proceed to include this CSS file in all five related files. Additionally, I enhance the 'View/Home/Welcome' file with CSS styling for a more visually appealing and cohesive appearance. To make the project more engaging, I incorporate five images of sticks, adding a graphical element to the content.

After these final touches and all the hard work, I've successfully completed my project. It's worth mentioning that this achievement comes after facing several challenges during the initial development, which required me to rebuild the entire project. Through persistent effort, error detection, and corrections, I've ultimately brought my project to its successful completion.
Time: 4:10AM
