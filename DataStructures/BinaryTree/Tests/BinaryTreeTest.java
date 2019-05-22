import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class BinaryTreeTest {

    private BinaryTree binaryTree;

    @BeforeEach
    void InitializeDependencies() {

        binaryTree = new BinaryTree();
    }
    @Test
    void BinaryTreeInsert_InsertRoot() {
        binaryTree.insert(5);
        assertEquals(true, binaryTree.find(5));
    }

    @Test
    void BinaryTreeInsert_InsertChildofRoot() {
        binaryTree.insert(5);
        binaryTree.insert(7);
        assertEquals(true, binaryTree.find(7));
    }

    @Test
    void BinaryTreeInsert_InsertKey() {
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(5);
        assertEquals(true, binaryTree.find(6));
    }

    @Test
    void BinaryTreeFind_ReturnsTrueIfKeyFound() {
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(9);
        assertEquals(true, binaryTree.find(9));
    }

    @Test
    void BinaryTreeFind_ReturnsFalseIfKeyNotFound() {
        binaryTree.insert(5);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(9);
        assertEquals(false, binaryTree.find(11));
    }
}