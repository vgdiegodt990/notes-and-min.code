import re
#data from call 
str = '5846943969 extra info burp anymore info burp test'
#regex compile info 
regex = re.compile('\d[0-9]+|burp', re.I)
callarrayinfo = regex.findall(str)
#print(callarrayinfo) - use this to access the phone number and burp
callmessage = regex.sub('', str)
#print(callmessage) - use this to access the message in the call (w/o burp and the number)