#!/bin/bash
set -euo pipefail
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PACK_DIR="$SCRIPT_DIR/pack"
rm -rf "$PACK_DIR"
cp -r "$SCRIPT_DIR/content/GreenStack.Umbraco.TheStarterKit" "$PACK_DIR"
cp -r "$SCRIPT_DIR/template-config/.template.config" "$PACK_DIR/.template.config"
echo "Pack directory assembled at: $PACK_DIR"
