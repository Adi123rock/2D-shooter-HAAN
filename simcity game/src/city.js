export function createCity(size) {
    const tiles=[];//2D data array

    initialize();//called before to make sure our data is initialized
    function initialize(){
        for(let x=0;x<size;x++){
            const column=[];//x,y coordinates of each tile in a column
            for(let y=0;y<size;y++){
                const tile=createTile(x,y);
                column.push(tile);
            }
            tiles.push(column);
        }
    }

    function update(){
        // console.log(`Updating city`);
        for(let x=0;x<size;x++){
            // const column=[];
            for(let y=0;y<size;y++){
                console.log(tiles[x][y]);
                tiles[x][y].building?.update();
            }
        }
    }
    return{
        size,
        tiles,
        update
    }
}

function createTile(x,y){
    return{
        x,
        y,
        terrainId:'ground',
        building:undefined,//building will be an building object
    };
}