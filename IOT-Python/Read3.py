#!/user/bin/env python
import RPi.GPIO as GPIO
import SimpleMFRC522
import json 
import time
from datetime  import datetime
from pymongo import MongoClient

#Metodo para escrever em arquivo Json
#Escrevo em formato json para comparar se os dados chegam ao #banco de dados
         
def writeToJSONFile(path, fileName, data):
    filePathNameWExt = './' + path + '/' + fileName + '.json'
    with open(filePathNameWExt, 'a') as fp:
        json.dump(data, fp)
       
#Metodo para Salvar no banco de dados remoto
def InsertOne (data):
    client = MongoClient('192.168.1.76', 27017)
    db = client.teste    
    db.funcionarios.insert_one(data)         
        
#Loop para monitorar quando alguém encosta o cartão no sensor
while ( 1 != 2):
        
    reader = SimpleMFRC522.SimpleMFRC522()      
           
    try:
	   #Insere a tag e o nome do dono do cartão nas variaveis        
        id,text = reader.read()
        print(id) #Imprimi a tag do cartão
        print(text) #Imprimi o nome do usuário
        
    finally:
        GPIO.cleanup()
        data = {} #Objeto 
        data['Nome'] = text #Insiro campo nome no objeto data 
        data['CardId'] =  id #Insiro campo id no objeto data
      
        time.sleep(3) //delay para ler o cartão apenas 1 vez
        
        #Escreve objeto em json
        writeToJSONFile('./','teste',data)
        
        #Insere o Objeto na banco de dados remoto
        InsertOne(data)
    





