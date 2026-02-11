import minecraft_launcher_lib
directory = "versions/"

def installMinecraft():
    gir=input("indirilecek versiyonu yaz :")
    if(gir==" "):
        print("indirilecek versiyonu yaz")
    else:
        minecraft_launcher_lib.install.install_minecraft_version(gir, directory)

def getVersionList(dir):
    for version in minecraft_launcher_lib.utils.get_installed_versions(dir):
        print("yüklü olanlar :",version["id"])


#eğer yeni versiyon indirmek istiyorsan :
#installMinecraft()