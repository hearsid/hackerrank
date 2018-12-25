def print_formatted(number):
    result = ''
    just_length_deci = len(str(number)[2:])+2
    just_length_octal = len(str(oct(number)[2:]))+2
    just_length_hexa = len(str(hex(number)[2:]))+2
    just_length_bin = len(str(bin(number)[2:]))+1
    for i in range(1,number+1):
        deci = str(i)
        octal = str(oct(i)[2:])
        hexa = str(hex(i)[2:]).upper()
        bi = str(bin(i)[2:])
        result += deci.rjust(just_length_bin-1)+octal.rjust(just_length_bin)+hexa.rjust(just_length_bin)+bi.rjust(just_length_bin)+"\n"
    print(result)



