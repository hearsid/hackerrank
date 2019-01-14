class Checker implements Comparator<Player> {
    public int compare(Player o1, Player o2) {
        if(o1.score == o2.score)
            return o1.name.compareTo(o2.name);
        return o2.score - o1.score;
    }
}
