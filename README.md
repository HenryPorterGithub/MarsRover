# MarsRover
ASP.NET Core Web App (Razor)

# Update

The Rovers have now been upgraded to use C#

They use asp-for="", a model class, forms and Html.Raw, in compliance with Razor best practice

Normally, a form using C# must reload the entire page when posting content for server-side operations

That is not necessary here because of the magic of Razor. This is a trait it has in common with ReactJS and Blazor, two other frameworks I know!

# Documentation

For your consideration, a simple program that simulates the movement of two Mars Rovers.

The base project is an ASP.NET Core Web App

The HTML for the interface can be found in Index.cshtml

All movement calculations are performed using the Javascript in site.js

MoveRover() is the primary function which calls two nested functions

ChangeDirection() and DoMovement() are called depending on which command is active in the input string

You can configure the input as you wish, but you can break the calculations with invalid characters

Solutions to this programming challenge are all over the internet; I did not view or use them

# Commentary

Required Field Validation could prevent this

The Javascript is client-side so server-side validation would not work

Client-side RFV is best for user experience purposes, but it is easily bypassed with inspect element

Server-side RFV can be used to enhance security, for example by preventing SQL injection

This is especially important in scenarios where dynamic SQL is used in C#, a major security problem which one should never do

If you must choose one form of RFV, you should use server-side

Unit Testing could be used to gain some protection against unexpected scenarios

Automated Testing is a critical part of contemporary CI/CD, I use it myself in my Automated Release and Testing Pipelines

For example, one could create unit tests that randomly change the inputs and then evaluate the output against an expected standard

My team and I pioneered the implementation of CI/CD, DevOps, Automation and Security enhancements throughout my time in my current position

Proper unit testing is challenging because you need to have a good understanding of what you are building your tests against

It is possible to rip the Javascript out of this project, then host it on a Cloud Platform like Azure or AWS

Cloud Microservices can be called externally with an API, thereby transferring the computational burden to a scalable environment

I lead multiple projects as a part of our company-wide Cloud Migration that my team instigated

Microservices are easily monitorable, in my current position I commonly create tools and pipelines for data and business analytics

Every aspect of the usage of the Mars Rover microservice could be analyzed, from SQL Parallelism patterns and CPU loads for internal use, to KPIs on customer engagement with the tool for the wider business

I do these tasks in a role I created for myself in my current position

With respect to the front-end, I generated a palette based on Beige using an online tool, and created a border using a simple cascade

There is very little CSS used here and rightfully so

That said, I am confident with advanced CSS skills like Flexbox and Keyframes

Contemporary front-end development should be low-code/no-code using frameworks like ReactJS/Blazor and component libraries like MUI/MudBlazor

I am experienced in all of them

I led all Redesign, Accessibility and Responsiveness projects in my current position

The only sustainable, low-maintence, low-debt method for accessibility is to use components from libraries which are developed to WCAG standards

Thanks to Bootstrap this project is mobile-responsive (touch-wood, I tested it myself but without my normal suite of simulation tools)
