// https://selenium.dev/documentation/en/selenium_installation/installing_selenium_libraries/
// https://selenium.dev/documentation/en/webdriver/driver_requirements/
// https://selenium.dev/documentation/en/webdriver/browser_manipulation/
// https://selenium.dev/documentation/en/getting_started_with_webdriver/locating_elements/

const webdriver = require( 'selenium-webdriver' );

( async function myFunction() {

    const driver = await new webdriver.Builder().forBrowser( 'chrome' ).build();

    await driver.get( 'https://trends.google.com/trends/hottrends/visualize' ); 
     
    const e00 = driver.findElement(webdriver.By.id( "0-0" ));  
    const e00innerText = await e00.getAttribute('innerText');
    
    console.log( e00innerText ); // .done-typing

} )();