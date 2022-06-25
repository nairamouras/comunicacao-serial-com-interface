//O potenciômetro está conectado ao GPIO 
const int sensor1Pin = 15;
const int sensor2Pin = 2;

//variável para armazenar o valor do potenciômetro
int svalor1 = 0;
int svalor2 = 0;

String mensagem = "";
void setup() {
  Serial.begin(115200);
  delay(1000);
}

void loop() { //// Lendo o valor do potenciômetro
  svalor2 = analogRead(sensor2Pin);
  svalor1 = analogRead(sensor1Pin);
  mensagem = String(svalor1) + ";" + String(svalor2);
  Serial.println(mensagem);
  delay(50);
}
