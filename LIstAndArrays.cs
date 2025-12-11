int []arr={1,2,3};
This is the fixed sixe array in C#
We cannot add or remove elements
It is fast and simple

NOW IF YOU HAVE TO PERFORM SUCH TYPES OF CRUD OPERATIONS ON ARRAY WE HAVE TO CONVERT THAT ARRAY INTO LIST TO DO IT

WHY CONVERTING TO LIST?

As it is resizable
Has  built in methods like Add(),Remove(),RemoveAt()

HOW TO DO IT?

Its converting array to list:-
List<int>list=nums.ToList();

Converting List to Array:-
  int []arr=list.ToArray();


