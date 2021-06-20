<h1>DevDen Assignment</h1>

<p>This solution is a derivative of the existing implementaion of object pooling for Scroll View UI Element of Unity, defined in this <a href="https://github.com/disas69/Unity-Pooled-Scroll-List#:~:text=An%20extension%20for%20Unity%20UI,vertical%20and%20grid%20layout%20groups.">repository</a>.</p>

<h2>Classes Used</h2>
<ol>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/PooledScrollList/Pool.cs">Pool.cs</a></h3></li>
        <p>
            This class is responsible for creating the pool of objects(prefab specified through) contructor calls. An instance of this class(used as singleton) is present wherever we are trying to establish an object pool. The object pool is implemented by preparing a Queue<T> which will hold a specific amount(specified thorugh inspector window) of objects during the contructor call. This class is primarily responsible for maintaining and cycling the queue.
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/PooledScrollList/PooledElement.cs">PooledElement.cs</a></h3></li>
        <p>
            This class is responsible for employing the Pool class, so it can create the object pool for the specific item type to be used in scroll list. 
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/PooledScrollList/PooledLayoutController.cs">PooledLayoutController.cs</a></h3></li>
        <p>
            This class is responsible for displaying list specific content on each item of the scroll list, recycling the items on going out of viewport, updating the RectTransform inside specific layout group(Horizontal/Vertical) and destroying the object pool on going out of scope to vaoid garbage collection.
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/PooledScrollList/PooledScrollRectController.cs">PooledScrollRectController.cs</a></h3></li>
        <p>
            This class is acts as the parent class of PooledLayoutControlled for implementing the changes in RectTransform of the items, viewport, layoutg groups nad other components as this class is the parent class and PooledLayoutController is overriding specific functions of it.
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/Tests/Item.cs">Item.cs</a></h3></li>
        <p>
            This class is responsible for deciding the structure of the item(s) which are displayed inside the scroll view. Here we are using a RawImage(Texture display from texture list), Image(background color from color list), Text(to display the index) and an instance of ItemData.
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/Tests/ItemElement.cs">ItemElement.cs</a></h3></li>
        <p>
            To implement and use the <a href="https://github.com/disas69/Unity-Pooled-Scroll-List#:~:text=An%20extension%20for%20Unity%20UI,vertical%20and%20grid%20layout%20groups.">extension</a>, it is necessary to create and implement a class inherited from PooledElement and attach it to the prefab that is displayed in the scroll. This is the class which inherits from PooledElement and implements getter and setter for Item and ItemData class.
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/Tests/ItemLayoutController.cs">ItemLayoutController.cs</a></h3></li>
        <p>
            An instance of this class is attached to the GameObject the holds the ScrollRect Component. It takes item prefab (specific to each scroll view for display) so the queue can be populated by intances of those prefabs. Similar to ItemElement's relation with PooledElement to instantiate the prefab objects through pooling, this class inherits from PooledLayoutController to recycle the items that are outside of of ViewPort and prepared them for display of next items in the scroll list.
        </p>
    <li><h3><a href="https://github.com/SKY-ROY/DevDen-Assignment/blob/main/Assets/Scripts/Tests/PooledScrollTest.cs">PooledScrollTest.cs</a></h3></li>
        <p>
            This class is specific to scene and use case for the scroll view, as it holds the list of colors to apply on item(prefab) and the list of textures to apply on the RawImage in each item(prefab) based on the index of the element in the lists.
        </p>
</ol>
<p>PROJECT FAILED</p>