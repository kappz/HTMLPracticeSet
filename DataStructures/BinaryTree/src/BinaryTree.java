import com.sun.org.apache.xpath.internal.operations.Bool;
import sun.reflect.generics.tree.Tree;
import java.util.*;

public class BinaryTree {
    private TreeNode root;
    private int height;

    BinaryTree() {
        root = null;
        height = 0;
    }

    public TreeNode getRoot() {
        return root;
    }
    public int getHeight() {
        return height;
    }

    public void insert(int value) {
        int currentHeight = 1;
        if (root == null) {
            root = new TreeNode((value));
            height = currentHeight;
        }
        else {
            insertRecursion(root, value, currentHeight);
        }
    }

    private TreeNode insertRecursion(TreeNode currentNode, int value, int currentHeight) {
        if (currentNode == null) {
            currentNode = new TreeNode((value));
        }
        else {
            if (currentNode.getKey() >= value) {
                ++currentHeight;
                currentNode.left = insertRecursion(currentNode.left, value, currentHeight);
            }
            else if (currentNode.getKey() < value) {
                ++currentHeight;
                currentNode.right = insertRecursion(currentNode.right, value, currentHeight);
            }
        }
        if (currentHeight > height) {
            height = currentHeight;
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

    public Vector<Integer> traverse(String traverseType) {
        Vector<Integer> traverse = new Vector<Integer>();

        traverseType.toLowerCase();
        traverseRecursion(root, traverse, traverseType);
        return traverse;
    }

    private void traverseRecursion(TreeNode currentNode, Vector<Integer> traverse, String traverseType) {
        if (currentNode == null) {
            return;
        }
        if (traverseType == "preorder") {
            traverse.add(currentNode.getKey());
        }
        traverseRecursion(currentNode.left, traverse, traverseType);
        if (traverseType == "inorder") {
            traverse.add(currentNode.getKey());
        }
        traverseRecursion(currentNode.right, traverse, traverseType);
        if (traverseType == "postorder") {
            traverse.add(currentNode.getKey());
        }
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
