//前方代号8
const int TrigPin1 = 2; 
const int EchoPin1 = 3;
//后方代号2
const int TrigPin2 = 4; 
const int EchoPin2 = 5;
//左方代号4
const int TrigPin3 = 6; 
const int EchoPin3 = 7; 
//右方代号6
const int TrigPin4 = 8; 
const int EchoPin4 = 9; 

void setup() 
{ 
Serial.begin(115200); 
pinMode(TrigPin1, OUTPUT); 
pinMode(EchoPin1, INPUT); 
pinMode(TrigPin2, OUTPUT); 
pinMode(EchoPin2, INPUT); 
pinMode(TrigPin3, OUTPUT); 
pinMode(EchoPin3, INPUT); 
pinMode(TrigPin4, OUTPUT); 
pinMode(EchoPin4, INPUT); 
} 
void loop() 
{ 
   chaoshengbo(8,TrigPin1,EchoPin1);
   chaoshengbo(2,TrigPin2,EchoPin2);
   chaoshengbo(4,TrigPin3,EchoPin3);
   chaoshengbo(6,TrigPin4,EchoPin4);

}

void chaoshengbo(int a,int m,int n)
{
  float cm;
  int b;
  //发一个60ms的高脉冲去触发TrigPin 
  digitalWrite(m, LOW); 
  delayMicroseconds(2); 
  digitalWrite(m, HIGH); 
  delayMicroseconds(60); 
  digitalWrite(m, LOW); 
  cm = pulseIn(n, HIGH)/ 58.0 ; //算成厘米 
  b =int(cm * 100.0); 
  //Serial.print("{"+"00"+a+b+"}"); //打印组合代号
  if(b>=10000)
  {
  Serial.print("{");
  Serial.print("00");
  Serial.print(a);
  Serial.print(b);
  Serial.print("}");
  Serial.println(); 
  }
  else if(b>=1000)
  {
  Serial.print("{");
  Serial.print("00");
  Serial.print(a);
  Serial.print("0");
  Serial.print(b);
  Serial.print("}");
  Serial.println(); 
  }
  else
  {
  Serial.print("{");
  Serial.print("00");
  Serial.print(a);
  Serial.print("00");
  Serial.print(b);
  Serial.print("}");
  Serial.println(); 
  }
  
}
