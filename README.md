# Final Project
## Iryna's Maroz final project in Vilnius Coding School. Automated and manual testing training Nov 2023.
### Tested website: [Pigu.lt](https://pigu.lt/lt/)
#### Test scenarios and cases are written for Google Chrome browser.

1. Login functionality

    	1.1 Results on entering Invalid Email format & Password
            1.1.1 Open webpage
            1.1.2 Click login button
            1.1.3 Fill email text box with invalid email format
            1.1.4 Fill password
            1.1.5 Click "submit"
            1.1.6 Assert error message seen
            1.1.7 Quit

2. Search functionality

        2.1 Text searching box
            2.1.1 Open webpage
            2.1.2 Place locator to text searching box
            2.1.3 Fill text searching box
            2.1.4 Search
            2.1.5 Assert items seen
            2.1.6 Quit

3. Hamburger menu functionality

        3.1  Availability to put item to shopping card via Hamburger menu
            3.1.1 Open webpage
            3.1.2 Click Hamburger menu button
            3.1.3 Choose category
            3.1.4 Choose subcategory
            3.1.5 Click "place to shopping cart" button under chosen item
            3.1.6 Click buy
            3.1.7 Assert shopping cart is filled with chosen item
            3.1.8 Quit

4. Shopping cart functionality

        4.1 "Continue" button in the cart
            4.1.1 Open webpage
            4.1.2 Place locator to text searching box
            4.1.3 Fill text searching box
            4.1.4 Search
            4.1.5 Click "place to shopping cart" button under chosen item
            4.1.6 Click buy
            4.1.7 Click continue
            4.1.8 Assert "Prisijungimas" option is seen
            4.1.9 Quit

5. Shopping cart functionality

        5.1 Cart is emptied after all items in cart deleted
            5.1.1 Open webpage
            5.1.2 Place locator to text searching box
            5.1.3 Fill text searching box
            5.1.4 Search
            5.1.5 Click "place to shopping cart" button under chosen item
            5.1.6 Buy
            5.1.7 Click delete
            5.1.8 Assert "shopping cart is empty" text available
            5.1.9 Quit