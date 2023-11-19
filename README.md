# Final Project
## Iryna's Maroz final project in Vilnius Coding School. Automated and manual testing training Nov 2023.
### Tested website: [Pigu.lt](https://pigu.lt/lt/)
#### Test scenarios and cases are written for Google Chrome browser.

    1. Purchase functionality

    	1.1 Log in with valid Email format & Password
            1.1.1 Open webpage
            1.1.2 Close cookies
            1.1.3 Click account button
            1.1.4 Click login button
            1.1.5 Fill email text box with valid email format
            1.1.6 Fill valid password
            1.1.7 Click "submit"
            1.1.8 Wait
            1.1.9 Assert welcome message is seen

    2. Purchase functionality

        2.1  Hamburger menu
            2.1.1 Precondition: page is opened, log in is successful
            2.1.2 Click Hamburger menu button
            2.1.3 Choose category
            2.1.4 Choose subcategory
            2.1.5 Wait
            2.1.6 Assert subcategory description is seen
   
    3. Purchase functionality

        3.1 Text searching box
            3.1.1 Precondition: page is opened, log in is successful
            3.1.2 Place cursor to text searching box
            3.1.3 Fill text searching box
            3.1.4 Search
            3.1.5 Select the first item
            3.1.6 Add it to the shopping cart
            3.1.7 Wait
            3.1.8 Assert item is in shopping cart
       

    4. Purchase functionality

        4.1 Purchasing without filling buyer credentials
            4.1.1 Precondition: page is opened, log in is successful, item added to the shopping cart
            4.1.2 Click buy
            4.1.3 Click continue
            4.1.4 Click submit button without filling any credentials
            4.1.5 Wait
            4.1.6 Assert name field border is red

    5. Purchase functionality

        5.1 Cart is emptied after all items in cart deleted
            5.1.1 Precondition: page is opened, log in is successful, item added to the shopping cart
            5.1.2 Click shopping cart button
            5.1.3 Wait
            5.1.4 Click delete
            5.1.5 Assert "shopping cart is empty" text available
            5.1.6 Quit
