if (confirm("Do you fly?  [OK=YES | Cancel = NO]")) {
    if (confirm("Are you wild?   [OK=YES | Cancel = NO]")) {
        document.writeln('<img src="./imgs/eagle.jpg" width=300px/> <br/> <h3>You are Eagle </h3> ');
    }else{
        document.writeln('<img src="./imgs/parrot.jpg" width=300px/> <br/> <h3>You are Parrot </h3> ');
    }
}else{
    if (confirm("Are you undersea?   [OK=YES | Cancel = NO]")) {
       if (confirm("Are you wild?   [OK=YES | Cancel = NO]")) {
        document.writeln('<img src="./imgs/shark.jpg" width=300px/> <br/> <h3>You are Shark </h3> ');
       } else {
        document.writeln('<img src="./imgs/dolphine.jpg" width=300px/> <br/> <h3>You are Dolphine </h3> ');
       }
    }else{
        if (confirm("Are you wild?   [OK=YES | Cancel = NO]")) {
            document.writeln('<img src="./imgs/lion.jpg" width=300px/> <br/> <h3>You are Lion </h3> ');
           } else {
            document.writeln('<img src="./imgs/cat.jpg" width=300px/> <br/> <h3>You are Cat </h3> ');
           }
    }
}

