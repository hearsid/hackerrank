

def wrap(string, max_width):
    result = ''
    iterate_count = int(len(string)/max_width)+1
    letter_pos = 0
    for i in range(iterate_count) :
        result += string[letter_pos:letter_pos+max_width]+"\n"
        letter_pos += max_width
        
    return result


