package EMP.Lab_8;

/**
 * Created by ol on 15.11.2015.
 */
public class Employee {
    private String name;
    public Employee() {
        name = "Oleg";
    }

    public Employee(String name) {
        this();
        //this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public static void main(String[] args) {
        Employee employee = new Employee("igor");
        System.out.println(employee.getName());
    }
}
