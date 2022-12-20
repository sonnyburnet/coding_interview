# shell.nix
{ pkgs ? import (builtins.fetchTarball {url = "https://github.com/NixOS/nixpkgs/archive/refs/tags/22.11-beta.zip";}) {}
, dotnet-sdk_7 ? pkgs."dotnet-sdk_7"
, gcc ? pkgs."gcc"
 }:

pkgs.mkShell {
  buildInputs = [ dotnet-sdk_7 gcc ];
}