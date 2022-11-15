class LinkedList {
    Node head;    

    // insert at the end of the list
    public void insert(int data){
        Node node = new Node();
        node.data = data;

        // If no head, assign this node as head
        if (head == null) head = node;
        else {
            Node n = head;
            while(n.next != null) n = n.next;
            n.next = node;
        }
    }

    // insert at the start of the list
    public void insertAtStart(int data){
        Node node = new Node();
        node.data = data;
        node.next = head;

        head = node;
    }
    
    // insert at a specific index
    public void insertAt(int index, int data){
        Node node = new Node(); 
        node.data = data;

        // add to start 
        if (index == 0) insertAtStart(data);
        else {
            Node n = head;
            for (int i = 0; i < index - 1; i++) n = n.next;
            node.next = n.next;
            n.next = node; 
        }
    }

    public void delete(int index){
        if (index == 0) head = head.next;
        else{
            Node n = head, n1 = null;
            for (int i = 0; i < index - 1; i++) n = n.next;
            n1 = n.next;
            n.next = n1.next;
            n1 = null;
        }
    }

    public void display(){
        Node n = head;
        while(n.next != null){
            System.out.printf("| %d | -----> ", n.data);
            n = n.next;
        }
        System.out.printf("| %d |", n.data);
    }
}
