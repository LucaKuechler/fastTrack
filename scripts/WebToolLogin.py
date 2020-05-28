from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time

thisdict = {
  "UsernameMain": "Your Username 1",
  "PasswordMain": "Your Password 1",
  "Username": "Your Username 2",
  "Password": "Your Password 2"
}

usernameMain = thisdict["UsernameMain"]
username = thisdict["Username"]
passwordMain = thisdict["PasswordMain"]
password = thisdict["Password"]



#init
class WebControl:

    def __init__(self, usernameMain, passwordMain, username, password):
        self.usernameMain = usernameMain
        self.passwordMain = passwordMain
        self.username = username
        self.password = password 
        self.driver = webdriver.Opera()
        self.handels = 0

    
    def closeBrowser(self):
        self.driver.close()


    def c_panel(self):

        driver = self.driver
        driver.get("https://www.hostinger.com/cpanel-login")

        while True:
            try:
                time.sleep(2)
                email_name_elem = driver.find_element_by_xpath("//input[@name='email']")
                email_name_elem.clear()
                email_name_elem.send_keys(self.usernameMain)

                password_name_elem = driver.find_element_by_xpath("//input[@name='password']")
                password_name_elem.clear()
                password_name_elem.send_keys(self.passwordMain)

                login_button = driver.find_element_by_xpath("//input[@value='Login']")
                login_button.click()
            except:
                pass   
            else:
                break

        hostingerLogin.file_manager()

    
    def file_manager(self):
        driver =  self.driver
        driver.execute_script('''window.open("https://nl-files.hostinger.com", "_blank");''')
        self.handels = driver.window_handles
        
        while True:
            try:
                driver.switch_to.window(self.handels[1])
            except:
                pass   
            else:
                break

        while True:
            try:
                time.sleep(2)
                email_name_elem = driver.find_element_by_xpath("//input[@ng-model='user.login.input.username']")
                email_name_elem.clear()
                email_name_elem.send_keys(self.username)

                password_name_elem = driver.find_element_by_xpath("//input[@id='input-password']")
                password_name_elem.clear()
                password_name_elem.send_keys(self.password)

                login_button = driver.find_element_by_xpath("//button[@class='btn btn-primary btn-lg btn-login']")
                login_button.click()
            except:
                pass   
            else:
                break

    
hostingerLogin = WebControl(usernameMain, passwordMain, username, password)
hostingerLogin.c_panel()



