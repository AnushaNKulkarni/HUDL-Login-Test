## Apps and packages to be installed:

 **1.IDE USED:**
Visual studio 2022

Download link: https://www.techspot.com/downloads/7493-visual-studio-2022.html

*Note: Any IDE can be used, but the installition of packages has to be according to the IDE under use.*

 **2. EXTENSIONS :**
 
 ![image](https://user-images.githubusercontent.com/119695514/205358681-caed98a0-6159-4175-a012-36b45e49bde7.png)
 
 
**3. DRIVER Used: Chrome**

Download link if needed: https://chromedriver.chromium.org/downloads

*Note: The driver.exe file will be downloaded when the packages are downloaded*

*Note 1: Make sure to match the ChromeDriver version with the Chrome browser version. If unmatched System.Reflection.TargetInvocationException will be thrown*
*Nore 2: The user can install any driver of their choice, the broswer and driver versions should match and user needs to initialize the chosen driver in StepBindings
 
 **4. NUGET PACKAGES :**

![image](https://user-images.githubusercontent.com/119695514/205359105-8e38f6ce-1d46-40a0-952e-6d805c52317d.png)



## SETUP INSTRUCTIONS:

1. Download and install all the necessary packages, extensions and IDE ( restarting of the IDE may be needed after installations )

2. Download the project 

3. Make sure the variable parameters 'Email' & 'Password' are properly filled in the feature file. Failing to do so will not execute credential sensitive tests

4. Clean and Build the project/solution

5. To run you tests: Open the 'View' menu -> select the 'Test Explorer'. 

6. In the test explorer right click on solution and click Run

7. To run indivisual tests, right click on the individual tests and click on Run

