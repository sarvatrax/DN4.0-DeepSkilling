import java.util.Arrays;
import java.util.Comparator;

public class Search {

    public static Product linearSearch(Product[] products, String name) {
        for (Product product : products) {
            if (product.productName.equalsIgnoreCase(name)) {
                return product;
            }
        }
        return null;
    }

    public static Product binarySearch(Product[] products, String name) {
        int low = 0;
        int high = products.length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;
            int cmp = products[mid].productName.compareToIgnoreCase(name);

            if (cmp == 0) return products[mid];
            else if (cmp < 0) low = mid + 1;
            else high = mid - 1;
        }
        return null;
    }

    public static void main(String[] args) {
        Product[] products = {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shirt", "Clothing"),
            new Product(103, "Book", "Education"),
            new Product(104, "Mouse", "Electronics"),
            new Product(105, "Shoes", "Footwear")
        };

        Product result1 = linearSearch(products, "Shirt");
        System.out.println("Linear Search Result: " + result1);

        Arrays.sort(products, Comparator.comparing(p -> p.productName.toLowerCase()));
        Product result2 = binarySearch(products, "Shirt");
        System.out.println("Binary Search Result: " + result2);
    }
}
