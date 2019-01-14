def count_substring(string, sub_string):
    loop_times = int(len(string)/len(sub_string));
    total = [1 for i in range(0,len(string)) if string[i: i+len(sub_string)] == sub_string]
    total = sum(total) 
    return total


