{
  description = "Flake for developing Recipe Book";

  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs";
  };

  outputs = { self, nixpkgs }: 
    let
      allSystems = [
	"x86_64-linux"
	"aarch64-linux"
      ];

      forAllSystems = f: nixpkgs.lib.genAttrs allSystems (system: f {
	pkgs = import nixpkgs { inherit system; };
      });
    in
    {
      devShells = forAllSystems
	({ pkgs }: {
	  default = pkgs.mkShell {
	    buildInputs = with pkgs; [ zsh just dotnet-sdk_10 docfx];
	    
	    shellHook = ''
	      zsh
	      exit
	    '';
	  };
	});
    };
}
