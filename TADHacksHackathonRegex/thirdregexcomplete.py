import re 

"""
print(str)
sentence = str.replace(" ", "")
print(sentence)

regex = re.compile('(\s*?)BURP(\s*?)', re.I)
another = regex.sub(' ', sentence)
print(another)
print(type(another))
x = another.split()
print(x)
"""

#code section that works 
str = '5846943969 lskdjflsdk burp burp'

regex = re.compile('\d[0-9]+|burp', re.I)
#print(str.index("8"))
#print(str.index("4"))
another = regex.findall(str)
print(another)
#print(another.group())

#delete from string
regdel = regex.sub('', str)
print(regdel)