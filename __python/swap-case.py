def swap_case(s):
    newString = "";
    for i in s:
        if(i.istitle()):
            i = i.lower()
        else:
            i = i.upper()
        newString+=i;
    return newString


