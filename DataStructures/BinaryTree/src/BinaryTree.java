import com.sun.org.apache.xpath.internal.operations.Bool;
import sun.reflect.generics.tree.Tree;

public class BinaryTree {
    private TreeNode root;

    BinaryTree() {
        root = null;
    }

    public TreeNode getRoot() {
        return root;
    }

    public void insert(int value) {
        if (root == null) {
            root = new TreeNode((value));
        }
        else {
            insertRecursion(root, value);
        }
    }

    private TreeNode insertRecursion(TreeNode currentNode, int value) {
        if (currentNode == null) {
            currentNode = new TreeNode((value));
        }
        else if (currentNode.getKey() >= value) {
            currentNode.left = insertRecursion(currentNode.left, value);
        }
        else if (currentNode.getKey() < value) {
            currentNode.right = insertRecursion(currentNode.right, value);
        }

        return currentNode;
    }

    public void delete(int value) {
            deleteRecursion(root, value);
    }

    private TreeNode deleteRecursion(TreeNode currentNode, int value) {
        int smallestValue;

        if (root == null) {
            return currentNode;
        }

        if (currentNode.getKey() == value) {
            if (currentNode.left == null && currentNode.right == null) {
                return null;
            }
            if (currentNode.left == null) {
                return currentNode.right;
            }
            else if (currentNode.right == null) {
                return currentNode.left;
            }
            else {
                smallestValue = findSmallestValue(currentNode.right);
                currentNode.setKey(smallestValue);
                currentNode.right = deleteRecursion(currentNode.right, smallestValue);
            }
        }
        else if (currentNode.getKey() > value) {
            currentNode.left = deleteRecursion(currentNode.left, value);
        }
        else if (currentNode.getKey() < value) {
            currentNode.right = deleteRecursion(currentNode.right, value);
        }

        return currentNode;
    }

    public boolean find(int value) {
        return findRecursion(root, value);
    }

    private boolean findRecursion(TreeNode currentNode, int value) {
        boolean keyFound = false;

        if (currentNode == null) {
            keyFound = false;
        }
        else if (currentNode.getKey() == value) {
            keyFound = true;
        }
        else if (currentNode.getKey() > value) {
            keyFound = findRecursion(currentNode.left, value);
        }
        else {
            keyFound = findRecursion(currentNode.right, value);
        }
        return keyFound;
    }

    public void print() {
        printRecursion(root);
    }

    private void printRecursion(TreeNode currentNode) {
        if (currentNode == null) {
            return;
        }

        printRecursion(currentNode.left);
        System.out.print(currentNode.getKey() + " ");  // Move before/after recursive calls to change traversal type.
        printRecursion(currentNode.right);
    }

    private TreeNode createTreeNode(int value) {
        TreeNode node = new TreeNode(value);
        return node;
    }
    private int findSmallestValue(TreeNode currentNode) {
        if (currentNode.left == null) {
            return currentNode.getKey();
        }
        return findSmallestValue(currentNode.left);
    }
}
