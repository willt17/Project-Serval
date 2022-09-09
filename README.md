# Project-Serval
Welcome to my project, I am attempting to make the worlds first open source timing and scoring system for racing of all kinds with a primary focus on harescrambles and enduros. I'm currently fleshing out the basic logic to handle inputs and outputs but will eventually look to add a web based ui as well as getting hardware demos working.
The main idea is to have the primary logic written in C# using the dotnet framework running locally on low powered hardware such as a Raspberry pi. the other necessary hardware will be an rfid reader to pick up riders transponders as they pass through finish lines or gates.
in addition to the main program and ui I anticipate we will need a database solution more than likely SQLite.
Update 09-09-2022.
I'm back working on this project after a short break over the summer, the plan for this fall is to flesh out the main logic as well as refactoring the code with more solid design principles. The current version will be designated as version 0.1
In order to reach the 0.2 milestone I need the main logic functioning as well as mocking up a UI to be used in a web browser.
The 0.3 milestone will be transitioning the main console application to a local API to update the web UI.