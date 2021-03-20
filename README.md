# SeleniumSpecflow #

This project is developed with Selenium, Specflow libraray with page object model design pattern.

* **IDE** : Visual Studio 2019 Community version
* **Programming Language** : C#
* **SDK** : Dot Net Core 3.1
* **Library Used** : Selenium, Selenium Support, Selenium Extras waithelper, Specflow, Nunit, Specflow Nunit
* **ChromerDriver Version** : 89.0.4389.23
* **Chromer Version** :  89.0.4389.90

### How to setup project ###

* Download and install [Visual Studio 2019 community version](https://visualstudio.microsoft.com/downloads/)
* Download and install [dot net core 3.1](https://dotnet.microsoft.com/download)
* Open Visual Studio IDE and navigate to the Extensions -> Manage Extension -> Install **SpecFlow for visual studio 2019**
* Download and install [Git](https://git-scm.com/downloads)
* Open command prompt and enter command **git clone https://stephenshinde12@bitbucket.org/stephenshinde12/seleniumspecflow.git**
* once projject clone complete then navigate to the folder and click on **TestAutomationTask.sln** file

### How to run project ###

* In Visual studio, Click on Build -> Clean Solution
* Click on Build -> Build Solution
* Click on Test -> Test Explorer
* Run **DuckDuckgoTask.features** and **ExpediaTask.features**

### Project Structure ###

* **CoreAutomation** - Contains reusable helper class folder and Base class folder that will share with DuckDuckgoTask and ExpediaTask project.
* **DuckDuckgoTask** - Contains test cases related to duduckgotesk
*   - Drivers - Chromedriver executable file
*   - Features - feature file with test scenario's
*   - Pages - locators and test steps
*   - StepDefinations - test cases
*   - TestScreenshot - Captured screenshot
* **ExpediaTask**
*   - Drivers - Chromedriver executable file
*   - Features - feature file with test scenario's
*   - Pages - locators and test steps
*   - StepDefinations - test cases
*   - TestScreenshot - Captured screenshot