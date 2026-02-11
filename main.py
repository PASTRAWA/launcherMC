import minecraft_launcher_lib
from src.launchMinecraft import launchMc
from src import settingsMinecraft 
import subprocess
import time
directory = "src/versions"

options = {
    "executablePath": "jdk8u482-b08/bin/java.exe",
    "username" : " ",
    "jvmArguments" : ["-Xmx4G", "-Xms4G"]
}


def main():
    isim=input("isim gir :")
    options["username"] = isim
    settingsMinecraft.getVersionList(directory)
    vers=input("versiyonu gir :")
    print(options["username"], options["jvmArguments"], vers,"AYARLARIYLA BAŞLATILIYOR...")
    time.sleep(3)
    launchMc(vers,directory,options)
    

main()