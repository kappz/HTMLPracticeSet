import com.sun.org.apache.xpath.internal.operations.Bool;

public class BinaryTree {
    private TreeNode root;

    BinaryTree() {
        root = null;
    }

    public void insert(int value) {
        if (root == null) {
            root = new TreeNode((value));
        }
        else {
            insertRecursion(root, value);
        }
    }
    private TreeNode createTreeNode(int value) {
        TreeNode node = new TreeNode(value);
        return node;
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
        printTree(root);
    }

    private void printTree(TreeNode currentNode) {
        if (currentNode == null) {
            return;
        }

        printTree(currentNode.left);
        System.out.print(currentNode.getKey() + " ");  // Move before/after recursive calls to change traversal type.
        printTree(currentNode.right);
    }
}
