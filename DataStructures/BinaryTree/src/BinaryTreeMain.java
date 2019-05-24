public class BinaryTreeMain {
    public static void main(String[] args) {
        BinaryTree binaryTree = new BinaryTree();
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(8);

        binaryTree.traverse("preorder");
        binaryTree.traverse("inorder");
        binaryTree.traverse("postorder");
    }
}
