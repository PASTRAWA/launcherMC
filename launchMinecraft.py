import minecraft_launcher_lib 
import subprocess
def launchMc(version, directory, options):
    startMC = minecraft_launcher_lib.command.get_minecraft_command("1.8.9", directory, options)
    subprocess.call(startMC)