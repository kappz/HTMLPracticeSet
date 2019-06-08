import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import java.util.*;

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
        assertEquals(5, binaryTree.getRoot().getKey());
    }

    @Test
    void BinaryTreeInsert_InsertChildOfRoot() {
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
    void BinaryTreeHeight_HeightIncrementedAfterTreeHeightIncreases() {
        int expected = 3;
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(5);
        binaryTree.insert(3);
        binaryTree.insert(6);
        assertEquals(expected, binaryTree.getHeight());
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

    @Test
    void BinaryTreeDelete_DeletesLeaf() {
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.delete(7);
        assertEquals(false, binaryTree.find(7));
    }

    @Test
    void BinaryTreeDelete_DeleteTreeNodeWithOneChild() {
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.delete(7);
        assertEquals(false, binaryTree.find(7));
        assertEquals(true, binaryTree.find(6));
    }

    @Test
    void BinaryTreeDelete_DeleteTreeNodeWithTwoChild() {
        binaryTree.insert(12);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(11);
        binaryTree.insert(10);
        binaryTree.insert(9);
        binaryTree.delete(7);
        assertEquals(false, binaryTree.find(7));
        assertEquals(true, binaryTree.find(9));
    }

    @Test
    void BinaryTreeTraverse_CorrectlyOrdersInOrderTraversal() {
        Vector<Integer> expected = new Vector<Integer>();
        Vector<Integer> actual;
        expected.add(6);
        expected.add(7);
        expected.add(8);
        expected.add(9);
        expected.add(13);
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(8);
        actual = binaryTree.traverse("inorder");
        assertEquals(expected, actual);
    }

    @Test
    void BinaryTreeTraverse_CorrectlyOrdersPostOrderTraversal() {
        Vector<Integer> expected = new Vector<Integer>();
        Vector<Integer> actual;
        expected.add(6);
        expected.add(8);
        expected.add(7);
        expected.add(13);
        expected.add(9);
        binaryTree.insert(9);
        binaryTree.insert(7);
        binaryTree.insert(13);
        binaryTree.insert(6);
        binaryTree.insert(8);
        actual = binaryTree.traverse("postorder");
        assertEquals(expected, actual);
    }
}