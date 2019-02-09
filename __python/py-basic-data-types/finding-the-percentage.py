if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
    
def get_avg(scores):
    return sum(scores)/len(scores)

result = get_avg(student_marks[query_name])
result= "%.2f"%result
print(result)
        
