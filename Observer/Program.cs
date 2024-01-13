using Observer;

var subject = new Subject();
var observer1 = new ConcreteObserver1();
subject.Attach(observer1);

var observer2 = new ConcreteObserver2();
subject.Attach(observer2);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Detach(observer2);

subject.SomeBusinessLogic();