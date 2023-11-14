class Person:
    "This class represents a car"
    
    name = ''
    surname = ''
    yearsOfBirth = 0
    address = ''
    
    def __init__(self, n, sn, yob, ad):
        self.name = n
        self.surname = sn
        self.yearOfBirth = yob
        self.address = ad
        
        
    def getName(self):
        return self.name
        
    def getSurname(self):
        return self.surname
    
    def getYOB(self):
        return self.yearOfBirth
        
    def getAdd(self):
        return self.address

Person_one = Person('Saed', 'Farah', 1998, '41 Richard Neale House')
    
print(Person_one.getName())
