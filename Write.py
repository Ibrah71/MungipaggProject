#!/user/bin/env python

#Programa para vincular uma pessoa a um cartão

import RPi.GPIO as GPIO
import SimpleMFRC522  

reader = SimpleMFRC522.SimpleMFRC522() #Instaciando objeto

try:
        text = raw_input('New data:')  #Pega O nome da pessoa
        
	  #pede para usuario encostar o cartão no leitor
        print("Now place your tag to write")
        
        #Vincula o usário com um cartão e salva na memória
        reader.write(text)
        print("Written")
finally:
        GPIO.cleanup()
