

**Practical work 2**

**GRADO EN INGENIERÍA INFORMÁTICA**

**CURSO ACADÉMICO 2024-25**

**23-05-2025**

**Table of Contents**

[1 Introduction 1](#_Toc198924618)

[2 Description 1](#_Toc198924619)

[2.1 Class diagram 2](#_Toc198924620)

[3 Problems 2](#_Toc198924621)

[4 Conclusions 2](#_Toc198924622)

# Introduction

This document provides a comprehensive overview of the development and implementation of a graphical base conversion application. The application supports a full user authentication system including registration, login, and password recovery, with user data persistently stored in a CSV file.

The main functionality of the application is a multi-format converter that allows users to perform base conversions between Decimal, Binary, Hexadecimal, Octal, and Two’s Complement representations. The main objective is to develop a user-friendly interface to maintain simplicity and resemble a physical calculator.

# Description

For starters, given the instructions, I decided to use 5 pages: LoginPage, RegistrationPage, MainPage, OperationsPage and PasswordRecoverPage. Before the implementation of the login, registration and showing all the different operations, I decided to first connect the calculator functionalities developed during the course to the code, which I did by adding every single one of the files used for the latest delivery except the program. They were introduced inside a folder, to maintain an ordered and clean structure, and the namespace of every file had to be modified to the actual namespace mentioning the folder too. Secondly, I implemented the main page functionality, which was the calculator interface. I decided to keep it as simple as possible and as similar as possible to the one given in the instructions but with my own preferences like colors. After verifying that the main page was working as expected, I continued with the development of the login and registration. Before coding, I had to decide which one was first and came to the conclusion that the registration was more important. Once I started, I had several doubts on how to approach this specific functionality, and remembered the instructions said the register must add the information of the user to a csv file. After I designed the .xaml file for the registration page, by the means of StreamReader and StreamWriter and a verification of the password format, I added the user info to the file. Once this was completed, the login just had to compare the username and password the user entered and compare it to the lines of the csv file to see if they matched or not. Once the design was simple, yet concise and containing only the relevant interfaces, I debated how to do the recover password functionality. On the one hand, I thought the user entering his username and comparing it to the one of the csv file and changing it like that was not a real-life scenario at all, but on the other hand I didn’t know how to ensure any other security methodologies, so I just decided to implement that. For the Operations page, it was straight up reading the file and comparing the actual user to the ones in the file and showing its information.

## Class diagram



# Problems

I mainly found three problems during the development of this practical work.

The main problem I found was everything that included MAUI. Nothing was working for me for starters, and I had to create many files because it was always giving me errors, and I thought the file was corrupted. Once I started verifying the namespaces and the naming in the .xaml files I discovered where the problem was, and I was not specifying the corresponding namespaces for some pages.

The other problem was within the changing of pages, as sometimes an exception appeared and it said that global routes cannot be done, and the opposite sometimes too. So I ended up just changing the ones that threw the exception and hoped it would work out, which indeed ended up working out

The last problem I found was with the operations page, as after the login, as I pressed the operations button from the main page the results were always empty, and it was because there was no user logged in. This took me a while to figure out, and I only did because I displayed alerts everywhere to check where the error was coming from.

# Conclusions

The solutions developed, particularly the user authentication system and conversion logic, proved to be both reliable and extensible. Implementing features like password validation and live error feedback improved user experience and application robustness.

Challenges such as managing page navigation flow, securely updating user data, and synchronizing input between UI and logic highlighted the importance of careful planning in multi-page applications. These lessons and technical insights will directly inform future projects, especially those involving persistent user data and platform-independent deployment.
