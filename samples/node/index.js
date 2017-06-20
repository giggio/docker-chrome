require('chromedriver');
const { By, until } = webdriver = require('selenium-webdriver');
const { Options } = require("selenium-webdriver/chrome");
const options = new Options();
options.options_["debuggerAddress"] = "127.0.0.1:9222";
const driver = new webdriver.Builder()
    .forBrowser('chrome')
    .setChromeOptions(options)
    .build();
driver.get('http://www.google.com/ncr');
driver.findElement(By.name('q')).sendKeys('webdriver node');
driver.findElement(By.name('btnG')).click();
async function get() {
    try {
        const found = await driver.wait(until.titleIs('webdriver node - Google Search'), 2000);
        console.log(`Found: ${found}`);
    } catch (error) {
        console.log(`Error: ${error}`);
    }
    if (driver) driver.quit();
}
get();