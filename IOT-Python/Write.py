#!/user/bin/env python

#Programa para vincular uma pessoa a um cart�o

import RPi.GPIO as GPIO
import SimpleMFRC522  

reader = SimpleMFRC522.SimpleMFRC522() #Instaciando objeto

try:
        text = raw_input('New data:')  #Pega O nome da pessoa
        
	  #pede para usuario encostar o cart�o no leitor
        print("Now place your tag to write")
        
        #Vincula o us�rio com um cart�o e salva na mem�ria
        reader.write(text)
        print("Written")
finally:
        GPIO.cleanup()
