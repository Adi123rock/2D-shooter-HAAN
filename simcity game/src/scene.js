import * as THREE from 'three';
import { createCameraManager } from './cameraManager.js';
import { createAssetInstance } from './assets.js';
export function createScene() {
    //Initial scene setup
    const gameWindow = document.getElementById('render-target')
    const scene = new THREE.Scene();
    // scene.background = new THREE.Color(0x777777);

    const cameraManager = createCameraManager(gameWindow);

    const renderer = new THREE.WebGLRenderer();
    renderer.setSize(gameWindow.offsetWidth, gameWindow.offsetHeight);
    renderer.setClearColor(0x000000, 0);//background color
    renderer.shadowMap.enabled = true;//enables shadow mapping
    renderer.shadowMap.type = THREE.PCFSoftShadowMap;//soft shadow mapping
    gameWindow.appendChild(renderer.domElement);

    //variables for the object selection
    const raycaster = new THREE.Raycaster();
    const mouse = new THREE.Vector2();//for mouse controlls

    let activeObject = undefined;//last object that was selected
    let hoverObject = undefined;//object the mouse is currently hovering over

    // let terrain = [];//keeps meshes of grass
    let buildings = [];//keeps meshes of buildings

    // let onObjectSelected = undefined;
    function initialize(city) {
        scene.clear();
        // terrain = [];
        buildings = [];
        for (let x = 0; x < city.size; x++) {
            const column = [];
            for (let y = 0; y < city.size; y++) {
                // const terrainId = city.data[x][y].terrainId;
                // console.log(city.data)
                const mesh = createAssetInstance(city.tiles[x][y].terrainId, x, y);//1.Create the mesh
                scene.add(mesh);//2.Add that mesh to the scene
                column.push(mesh);//3.Add that mesh to the meshes array

            }
            // terrain.push(column);
            buildings.push([...Array(city.size)])//creates columns of undefined value 
        }
        setupLights();
    }
    function update(city) {
        for (let x = 0; x < city.size; x++) {
            for (let y = 0; y < city.size; y++) {
                const tile = city.tiles[x][y];
                const existingBuildingMesh = buildings[x][y];
                
                // If there's no building in the tile but there is a mesh, remove it
                if (!tile.building && existingBuildingMesh) {
                    scene.remove(existingBuildingMesh);
                    buildings[x][y] = undefined;
                }
                // If there's a building and it needs updating, update it
                else if (tile.building && tile.building.updated) {
                    if (existingBuildingMesh) {
                        scene.remove(existingBuildingMesh);
                    }
                    buildings[x][y] = createAssetInstance(tile.building.type, x, y, tile.building);
                    scene.add(buildings[x][y]);
                    tile.building.updated = false;
                }
            }
        }
    }

    function setupLights() {
        const sun = new THREE.DirectionalLight(0xffffff, 1)
        sun.position.set(20, 20, 20);
        sun.castShadow = true;
        sun.shadow.camera.left = - 10;
        sun.shadow.camera.right = 10;
        sun.shadow.camera.top = 0;
        sun.shadow.camera.bottom = - 10;
        sun.shadow.mapSize.width = 1024;//quality
        sun.shadow.mapSize.height = 1024;//quality
        sun.shadow.camera.near = 0.5;
        sun.shadow.camera.far = 50;
        scene.add(sun);
        scene.add(new THREE.AmbientLight(0xffffff, 0.3));
        // const helper = new THREE.CameraHelper(sun.shadow.camera);
        // scene.add(helper);

    }
    function draw() {
        renderer.render(scene, cameraManager.camera);
    }
    function start() {
        renderer.setAnimationLoop(draw);
    }
    function stop() {
        renderer.setAnimationLoop(null);
    }

    /**  
     * Resizes the renderer to fit the current game window
    */
    function onResize() {
        cameraManager.camera.aspect = gameWindow.offsetWidth / gameWindow.offsetHeight;
        cameraManager.camera.updateProjectionMatrix();
        renderer.setSize(gameWindow.offsetWidth, gameWindow.offsetHeight);
    }
    /**  Sets the object that is currently highlighted
    * @param {THREE.Mesh} object
    */
    function setHighlightedObject(object) {
        // Unhighlight the previously hovered object (if it isn't currently selected)
        if (hoverObject && hoverObject !== activeObject) {
            setObjectEmission(hoverObject, 0x000000);
        }
        hoverObject = object;

        if (hoverObject) {
            // Highlight the new hovered object (if it isn't currently selected) )
            setObjectEmission(hoverObject, 0x555555);
        }
    }
    /** 
        Gets the object currently under the mouse cursor. If there is nothing under
    the mouse cursor, returns null
    
    @param {MouseEvent} event Mouse event
    */
    function getSelectedObject(event) {
        // Compute normalized mouse coordinates
        mouse.x = (event.clientX / renderer.domElement.clientWidth) * 2 - 1;
        mouse.y = - (event.clientY / renderer.domElement.clientHeight) * 2 + 1;
        raycaster.setFromCamera(mouse, cameraManager.camera);
        let intersections = raycaster.intersectObjects(scene.children, false);
        if (intersections.length > 0) {
            return intersections[0].object;
        } else {
            return null;
        }
    }

    /** 
    * Sets the currently selected object and highlights it
   * @param {object} object 
   */
    function setActiveObject(object) {
        // Clear highlight on previously active object
        setObjectEmission(activeObject, 0x000000);
        activeObject = object;
        // Highlight new active object
        setObjectEmission(activeObject, 0xaaaa55);
    }
    
    /**
    * Updates the material properties of the object to have the
    * specified emission color
    * @param {THREE.Mesh} object 
    * @param {number} color 
    * @returns 
    */
    function setObjectEmission(object, color) {
        if (!object) return;
        if (Array.isArray(object.material)) {
          object.material.forEach(material => material.emissive?.setHex(color));
        } else {
          object.material.emissive?.setHex(color);
        }
    }

    return {
        cameraManager,
        initialize,
        update,
        start,
        stop,
        onResize,
        getSelectedObject,
        setActiveObject,
        setHighlightedObject
    }
}