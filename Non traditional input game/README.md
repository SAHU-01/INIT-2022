# Speech-Recognition--Game
SpeechRecognition is compatible with Python 2.6, 2.7 and 3.3+, but requires some additional installation steps for Python 2. For this project, we have used 
python 3.3+, folllowed by SpeechRecognition package from which Recognizer class is used to easily recognize speech from both a file—using record()—and microphone input—using listen(). 
Segments of an audio file are processed using the offset and duration keyword arguments of the record() method.

The game allows the player to guess the word that the compiler chose at random. The player has to say the word for the compiler to reconginze 
and process further, hence speech recognition is being made.
