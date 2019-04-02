def minion_game(string):
    points = {'stuart': 0,'kevin': 0};
    vowels= list('AEIOU')
    # this is sick :D
    for i,s in enumerate(string):
        if s not in vowels:
                points['stuart'] += (len(string)-i)
        else:
                points['kevin'] += (len(string)-i)

    if points['stuart'] >points['kevin'] :
        print('Stuart '+str(points['stuart']))
    elif points['stuart'] < points['kevin']:
        print('Kevin '+str(points['kevin']))
    else:
        print('Draw')



