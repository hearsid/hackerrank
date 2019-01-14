names = []
scores = []
if __name__ == '__main__':
    for _ in range(int(input())):
        name = input()
        score = float(input())
        names.append(name)
        scores.append(score)

scores = list(scores)
originalScores = scores[:]
scores = set(scores)
scores = sorted(scores)
secondMinScore = scores[1]
indexes = [index for index, i in enumerate(originalScores) if i == secondMinScore]
winners = []
for x in range(len(indexes)):
    winners.append(names[indexes[x]])

winners = sorted(winners)

for i in range(len(winners)):
    print(winners[i])

