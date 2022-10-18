#testing
import re

#GOODBYETEST
string = "8 0 3 9 1 4 9 3 9 5 BURP"
prelim = re.split('BURP', string)
print(prelim)

def remove(prelim): 
    return string.replace(" ", "")
    
print(remove(prelim))

#another -yes yes hhis is the most successful oine so more 
str = 'The weather is really nice 8135551234 I am ok mom burp tomorrow should be better'
print(str)
sentence = str.replace(" ", "")
print(sentence)

regex = re.compile('(\s*)BURP(\s*)', re.I)
another = regex.sub(' ', sentence)
print(another)
print(type(another))
x = another.split()
print(x)

#print(type(x[2]))