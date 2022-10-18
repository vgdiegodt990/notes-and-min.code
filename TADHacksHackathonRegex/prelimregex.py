import re 
#preliminary
print("\tpreliminary")
dummytext = "818-490-4919 FirstName LastName BURP any other information"

regextest = re.split('BURP',dummytext)
print(regextest)

#unsuccess
print("\tunsuccess")
anotherdummy = "8 0 1 6 9 0 3 9 9 0 BURP"
print (anotherdummy)
anothertest = re.split('^(\s+)_BURP',anotherdummy)
print (anothertest)

#diff method
print("\tdiffmethod")

string = "8 0 1 6 9 0 3 9 9 0 BURP"
testx2 = re.split('BURP', string)
print(testx2)

def remove(string):
    #return string.replace(" ", "")
    #return "".join(string.split())
    pattern = re.compile(r'\s+')
    return re.sub(pattern, '', string)

print(remove(string))

""" separate
testx2 = re.split('BURP', string)
print(testx2)
"""