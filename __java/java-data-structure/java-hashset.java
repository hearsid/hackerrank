
        Set<String> hashset = new HashSet<String>();
        for(int i=0; i<t; i++) {
            String word = pair_left[i]+" "+ pair_right[i];
            hashset.add(word);
            System.out.println(hashset.size());
        }
