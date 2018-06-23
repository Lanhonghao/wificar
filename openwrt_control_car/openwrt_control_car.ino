
int cmd=0;
char shuju;
char a;
void setup()
{
Serial.begin(9600);
pinMode(7,OUTPUT);  
pinMode(10,OUTPUT);  
pinMode(8,OUTPUT);  
pinMode(9,OUTPUT); 
pinMode(A0,INPUT);  
pinMode(A2,INPUT);  
pinMode(A3,INPUT);  
pinMode(A4,INPUT); 
}
void loop() 
{              
  if(Serial.available()>0)
  {
    shuju=Serial.read();
//    Serial.print(shuju);
//    Serial.println();
    
  } 
 switch(shuju)
{
     case 'h':x();  break;
     case 'p': xunji();break;
     default: kaiche(shuju); 
   
  }

}

void r()
{
  digitalWrite(7,HIGH); 
  digitalWrite(8,LOW);  

}
void l()
{
  digitalWrite(7,LOW); 
  digitalWrite(8,HIGH);  

  }
void ww()
{
  
  digitalWrite(10,LOW); 
  digitalWrite(9,HIGH);  
}
void w()
{
  
  digitalWrite(10,LOW); 
  analogWrite(9,120);  

  }
void s()
{
  analogWrite(10,105); 
  digitalWrite(9,LOW);  

  }
void ss()
{
  digitalWrite(10,HIGH); 
  digitalWrite(9,LOW);  

  }
void x()
{
  digitalWrite(10,LOW); 
  digitalWrite(9,LOW);  
  digitalWrite(7,LOW); 
  digitalWrite(8,LOW);  
}

void kaiche(char shuju1)
{
switch(shuju1)
{
     case 'w': ww();  break;
     case 'd':  r();break;
     case 's': ss(); break;
     case 'a':  l(); break;
     default: x(); 
   
  }
}

void xunji()
{
    if(digitalRead(A3)==HIGH)
  {                               
   cmd=3;            
   }               
 if(digitalRead(A1)==HIGH)
    {                 
      cmd=2;
     }               
  if(digitalRead(A2)==HIGH)
  {                
    cmd=4;
  }
  if(digitalRead(A0)==HIGH)
  {                  
       cmd=1;
   }                
if(digitalRead(A0)==LOW&&digitalRead(A1)==LOW&&digitalRead(A2)==LOW&&digitalRead(A3)==LOW)
  {
     cmd=0;
  }
  switch(cmd)
  {
  case 0:digitalWrite(7,LOW); digitalWrite(8,LOW);w();break;
  case 1:l();w();delay(700);x();delay(500);r();s();delay(300);break;
  case 2: r();w();delay(700); x();delay(500);l();s();delay(300);break;
  case 3:l();s();delay(700); x();delay(500);r(); w();delay(300);break;
  case 4: r();s(); delay(700);x();delay(500);l();w();delay(300);break;
  default:x();
  } 
}
