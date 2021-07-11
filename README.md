
  <h3 align="center">HR_manager</h3>

  <p align="center">
    Human Resources Management Application API and SPA Client
    <br />
    <br />
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Users/welcome.JPG)] 


### Built With

* [Bootstrap 4]()
* [.NET]()
* [Blazor]()



<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites
1. clone repo to your pc
2. Set env variable on windows for JWT , with the name of KEY and value of some random 10 characters
3. run command  Update-Database


<!-- USAGE EXAMPLES -->
## Usage

 
Endpoints for the webservice on Swagger
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Users/swagger.JPG)] 

Register validation
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Users/registerErrors.JPG)] 

Register creates a record for the Employees table and the AspNetUsers table
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Users/registerSuccess.JPG)] 

Validation errors for logging time
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Users/LoggedTimeUserErrors.JPG)] 
 
Prevent one user from updating someone else's logs
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Users/ErrorIfUser2MakesChangesToUser1Time.JPG)] 

Admin can access the logs of all the users
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Admin/listUsers.JPG)] 
 
 Admin can update all logs
[![name](https://raw.githubusercontent.com/DavidMares22/HR_manager/master/screenshots/Admin/adminchangetime.JPG)] 
 
 
 

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/github_username
