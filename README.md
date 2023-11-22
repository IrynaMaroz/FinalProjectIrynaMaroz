# Final Project
## Iryna's Maroz final project in Vilnius Coding School. Automated and manual testing training Nov 2023.
### Tested website: [Pigu.lt](https://pigu.lt/lt/)
#### Test scenarios and cases are written for Google Chrome browser.

    1. Purchase functionality

    	1.1 Log in with valid Email format & Password
            1.1.1 Open webpage
            1.1.2 Wait
            1.1.3 Close cookies
            1.1.4 Wait
            1.1.5 Move to account button
            1.1.6 Click login button
            1.1.7 Fill email text box with valid email format
            1.1.8 Fill valid password
            1.1.9 Click "submit"
            1.1.10 Wait
            1.1.11 Assert welcome message is seen

    2. Purchase functionality

        2.1  Hamburger menu
            2.1.1 Precondition: page is opened, cookies closed
            2.1.2 Wait
            2.1.3 Move to Hamburger menu button
            2.1.4 Wait
            2.1.5 Choose category
            2.1.6 Wait
            2.1.7 Assert category description is seen
   
    3. Purchase functionality

        3.1 Text searching box
            3.1.1 Precondition: page is opened, cookies closed
            3.1.2 Place cursor to text searching box
            3.1.3 Wait
            3.1.4 Fill text searching box
            3.1.5 Search
            3.1.6 Select the first item
            3.1.7 Wait
            3.1.8 Add it to the shopping cart
            3.1.9 Wait
            3.1.10 Assert item is in shopping cart
       

    4. Purchase functionality

        4.1 Shopping cart "buy" button
            4.1.1 Precondition: page is opened, cookies closed, login success, item added to shopping cart
            4.1.2 Wait
            4.1.3 Click buy
            4.1.4 Wait
            4.1.5 Assert purchasing info visible

    5. Purchase functionality

        5.1 Cart is emptied after all items in cart deleted
            5.1.1 Precondition: page is opened, cookies closed, log in is successful, item added to the shopping cart
            5.1.2 Click buy button
            5.1.3 Wait
            5.1.4 Click delete
            5.1.5 Assert "shopping cart is empty" text available
            5.1.6 Quit
